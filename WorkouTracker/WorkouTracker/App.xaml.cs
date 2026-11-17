namespace WorkouTracker
{
    public partial class App : Application
    {
        // A DI itt fogja beadni az AppShell-t
        public App(AppShell shell)
        {
            InitializeComponent();
            _shell = shell;
        }

        private readonly AppShell _shell;

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Nem hozunk létre újat (new), hanem a kapott példányt használjuk
            return new Window(_shell);
        }
    }
}