using Contracts.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;

namespace UI.TextilSoft.MainForm
{
    public partial class FmLogin : Form
    {
        private readonly IUserController _userController;
        public FmLogin(IUserController userController)
        {
            InitializeComponent();
            _userController = userController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _userController.CreateUser(new IdentityUser());
            //AuthController authController = new AuthController(new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext())));
            //authController.CreateUser();
        }
    }
}
