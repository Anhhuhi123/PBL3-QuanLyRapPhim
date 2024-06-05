using BLL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DatMonAnBLL
    {
        CinemaUnitOfWork unitOfWork;
        public DatMonAnBLL()
        {
            unitOfWork = CinemaUnitOfWork.Instance;
        }

        public void ThemMonAn(DataGridView dataGridView1, Button sender)
        {
            
        }
    }
}
