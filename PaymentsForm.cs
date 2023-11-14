using Hotel.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm(List<Booking> dueDates)
        {
            InitializeComponent();

            if (dueDates.Count > 0)
            {

            }
        }
    }
}
