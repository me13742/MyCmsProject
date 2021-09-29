using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroupRepository : IPageGroupRepository
    {
        MyCmsContext db = new MyCmsContext();
        public IEnumerable<PageGroup> GetAllPageGroups()
        {
            return db.PageGroups;
        }

        public PageGroup GetGroupById(int groupId)
        {
            return db.PageGroups.Find(groupId);
        }

        public bool InsertGroup(PageGroup PageGroup)
        {
            try
            {
                db.PageGroups.Add(PageGroup);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteGroup(PageGroup pageGroup)
        {
            db.Entry(pageGroup).State = EntityState.Deleted;
            return true;
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupById(groupId);
                DeleteGroup(group);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
