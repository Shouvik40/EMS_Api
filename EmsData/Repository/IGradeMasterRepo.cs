using EmsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsData.Repository
{
    public interface IGradeMasterRepo
    {
        IList<Grade_Master> GetAllGradeMasters();
        Grade_Master GetGradeMasterByCode(string code);
        void AddGradeMaster(Grade_Master gradeMaster);
        void UpdateGradeMaster(Grade_Master gradeMaster);
        void DeleteGradeMaster(string code);
    }

}
