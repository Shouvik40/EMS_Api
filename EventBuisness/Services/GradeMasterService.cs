using EmsData.Repository;
using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Services
{
    public class GradeMasterService
    {
        private readonly IGradeMasterRepo _gradeMasterRepo;

        public GradeMasterService(IGradeMasterRepo gradeMasterRepo)
        {
            _gradeMasterRepo = gradeMasterRepo;
        }

        public IList<Grade_Master> GetAllGradeMasters()
        {
            return _gradeMasterRepo.GetAllGradeMasters();
        }

        public Grade_Master GetGradeMasterByCode(string code)
        {
            return _gradeMasterRepo.GetGradeMasterByCode(code);
        }

        public void AddGradeMaster(Grade_Master gradeMaster)
        {
            _gradeMasterRepo.AddGradeMaster(gradeMaster);
        }

        public void UpdateGradeMaster(Grade_Master gradeMaster)
        {
            _gradeMasterRepo.UpdateGradeMaster(gradeMaster);
        }

        public void DeleteGradeMaster(string code)
        {
            _gradeMasterRepo.DeleteGradeMaster(code);
        }
    }
}
