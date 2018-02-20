using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ND.MODAL;
using ND.BLL;
using ND.BLL.Exceptions;
using ND.BLL.Sistema;


namespace ND
{
    public partial class Default : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarBairro(); 
            }
        }

        //metodo para preencher os dropDawn
        private void carregarBairro() 
        {
            var _bairroBLL = new bairroBLL();
            dpBairro.DataSource = _bairroBLL.listarTodosBairros();
            dpBairro.DataBind(); 

        }
    }
}