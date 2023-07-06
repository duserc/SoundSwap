using getDevNameLibrary;
namespace NotificationForm;
public partial class SoundSwapNotification : Form
{
    protected override bool ShowWithoutActivation
    {
        get { return true; }
    }
    public SoundSwapNotification()
    {
        InitializeComponent();
        formLocation();
        setLabel();
        fadeOut();
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
        Opacity = 1.00;
        await Task.Delay(1200);

        for (int i = 0; i < 100; i++)
        {
            await Task.Delay(10);
            Opacity = 1.00 - (i*0.01);
        }
        this.Close();

    }

}