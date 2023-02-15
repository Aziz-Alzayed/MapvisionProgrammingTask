namespace MapvisionApp.ExceptionHandlers
{
    internal static class ExceptionFormsHandler
    {
        internal static void OnLoadForm(object sender, EventArgs e)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log the exception
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("An unhandled exception has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception
            Exception ex = e.Exception;
            MessageBox.Show("An unhandled thread exception has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
