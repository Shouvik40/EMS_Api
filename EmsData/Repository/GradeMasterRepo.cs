using System.Collections.Generic;
using System.Linq;
using EmsData.EmsDataContext;
using EmsEntity;

namespace EmsData.Repository
{
        public class GradeMasterRepo : IGradeMasterRepo
        {
            private readonly EmsDbContext _context;

            public GradeMasterRepo(EmsDbContext context)
            {
                _context = context;
            }

            public IList<Grade_Master> GetAllGradeMasters()
            {
                return _context.Grade_Masters.ToList();
            }

            public Grade_Master GetGradeMasterByCode(string code)
            {
                return _context.Grade_Masters.FirstOrDefault(g => g.Grade_Code == code);
            }

            public void AddGradeMaster(Grade_Master gradeMaster)
            {
                _context.Grade_Masters.Add(gradeMaster);
                _context.SaveChanges();
            }

            public void UpdateGradeMaster(Grade_Master gradeMaster)
            {
                _context.Grade_Masters.Update(gradeMaster);
                _context.SaveChanges();
            }

            public void DeleteGradeMaster(string code)
            {
                var gradeMaster = _context.Grade_Masters.FirstOrDefault(g => g.Grade_Code == code);
                if (gradeMaster != null)
                {
                    _context.Grade_Masters.Remove(gradeMaster);
                    _context.SaveChanges();
                }
            }
        }
    }

