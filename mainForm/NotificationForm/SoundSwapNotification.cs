using ChangeAudioVolumeLibrary;
using getDevNameLibrary;
using NAudio.CoreAudioApi;

namespace NotificationForm;
public partial class SoundSwapNotification : Form
{
    private System.Threading.Timer volumeUpdateTimer;
    private CancellationTokenSource fadeOutCancellation;
    protected override bool ShowWithoutActivation
    {
        get { return true; }
    }
    public SoundSwapNotification()
    {
        InitializeComponent();
        initializeAudioSlider();
        formLocation();
        setLabel();
        fadeOut();
        Volume.dev.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
    }
    private void formLocation()
    {
        StartPosition = FormStartPosition.Manual;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        int borderGap = 10;
        Location = new Point(screenWidth - Width - borderGap - 5, screenHeight - Height - borderGap - 50);
    }
    private void setLabel()
    {
        string activeDevice = DeviceName.soundDeviceName;
        SoundDevicelabel.Text = activeDevice;
    }
    private async Task fadeOut()
    {
        fadeOutCancellation?.Cancel();
        fadeOutCancellation = new CancellationTokenSource();

        Opacity = 1.00;
        await Task.Delay(1800, fadeOutCancellation.Token);

        for (int i = 0; i < 100; i++)
        {
            await Task.Delay(15, fadeOutCancellation.Token);
            Opacity = 1.00 - (i * 0.01);

            if (fadeOutCancellation.IsCancellationRequested)
                return;
        }
        this.Close();
    }

    private void initializeAudioSlider()
    {
        var volumeValue = Volume.getDeviceVolumeUsingName(DeviceName.soundDeviceName);
        volumeSlider.Value = Convert.ToInt32(volumeValue);
        volumeUiLabel.Text = $"{volumeValue}%";
    }

    private void volumeSlider_ValueChanged(object sender, EventArgs e)
    {
        Volume.ChangeDeviceVolumeUsingName(DeviceName.soundDeviceName, volumeSlider.Value);
        volumeUiLabel.Text = $"{volumeSlider.Value}%";
    }
    private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
    {
        volumeUpdateTimer?.Dispose();
        volumeUpdateTimer = new System.Threading.Timer(UpdateVolumeSlider, (int)(data.MasterVolume * 100), 10, Timeout.Infinite);
    }
    private void UpdateVolumeSlider(object state)
    {
        int volumeValue = (int)state;
        if (volumeSlider.IsHandleCreated)
        {
            volumeSlider.BeginInvoke(new Action(() =>
            {
                volumeSlider.Value = volumeValue;
                volumeUiLabel.Text = $"{volumeValue}%";
            }));
        }
    }
    private void volumeSlider_MouseHover(object sender, EventArgs e)
    {
        fadeOutCancellation?.Cancel();
        Opacity = 1.00;
    }

    private void volumeSlider_MouseLeave(object sender, EventArgs e)
    {
        fadeOut();
    }
}