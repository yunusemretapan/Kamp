using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { databaseLoggerService, fileLoggerService };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(needCreditManager, loggerServices);
            //applicationManager.MakeAnApplication(vehicleCreditManager);
            //applicationManager.MakeAnApplication(housingCreditManager);

            List<ICreditManager> creditManagers = new List<ICreditManager>() { vehicleCreditManager, needCreditManager, housingCreditManager };
            //applicationManager.MakeCreditPreNotification(creditManagers);
        }
    }
}
