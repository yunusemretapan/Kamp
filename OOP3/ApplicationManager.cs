using System.Collections.Generic;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            creditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }

        }

        public void MakeCreditPreNotification(List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();
            }
        }
    }
}
