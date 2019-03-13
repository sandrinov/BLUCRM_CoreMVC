using BLUCRM_CoreMVC.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLUCRM_CoreMVC.Repository
{
    public class RepositoryFactory
    {
        private static IRepository _repository;

        public RepositoryFactory()
        {
            // if......
            IRepository _repository = new EF_Repository(new EmployeeFactory());
        }

        public static IRepository GetRepository()
        {
            return _repository;
        }
    }
}
