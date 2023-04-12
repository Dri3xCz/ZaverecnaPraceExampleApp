namespace ZaverecnaPraceExampleUse
{
    using ZaverecnaPraceBaseDLL;

    // Your MainForm must use Interface IGameForm
    public partial class MainForm : Form, IGameForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Declaring IMainForm and setting it's value to new FakeForm for debugging
        IMainForm mainForm = new FakeForm();


        // InitForm method is used for instatiating form that
        // should be the entrypoint to your application, in my case it is this form

        public Form InitForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            return this;
        }

        // Must be implemented, use this method to properly end your game
        public void EndGame()
        {
            // End of the game

            // Your EndGame method must use method SendData from current IMainForm
            // Use any character you like
            mainForm.SendData('o');
        }

        // Must be implemented, use this method to properly restart your game
        // Then you can use it anywhere from the application
        public void Restart()
        {
            // Restart of the game
        }

        // Must be implemented, use this method to properly start your game
        public void StartGame()
        {
            // Start of the game
        }

        // Example button I created in this example
        // Calls method EndGame (Must be called somewhere in the apllication)
        private void exampleButton_Click(object sender, EventArgs e)
        {
            EndGame();
        }
    }
}