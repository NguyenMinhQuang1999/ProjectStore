using DAL.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Linq;
using Model;
namespace DAL
{
    public partial class ItemGroupRepository : IItemGroupReponsitory
    {
        private IDatabaseHelper _dbHelper;
        public ItemGroupRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<ItemGroupModel> GetData()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_item_group_get_data_tree_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ItemGroupModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
