using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class User : System.Web.UI.Page
    {
        public string err = "";
        static NetflixBL.User user;
        static NetflixWS.Card card;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!((string)Session["Login"] == "user"))
            {
                Response.Redirect("Login.aspx");
            }

             user = new NetflixBL.User((string)Session["Username"]);
            if (!Page.IsPostBack)
            {
                NetflixWS.NetflixWS proxyObj = new NetflixWS.NetflixWS();
                card = proxyObj.UserPayment(user.CreditCard);
                NetflixWS.Transaction payment = proxyObj.UserLatesPay("Netflix",card.CardNumber);
                PaymentID.Text += (" " + payment.ID);
                PaymentCard.Text += (" " + payment.CardNumber);
                PaymentAmount.Text += (" " +payment.Amount);
                PayerName.Text += (" " + card.FirstName + " " + card.LastName);
                NewEmail.Text = user.Email;
                NewPass.Text = user.Pass;
                NewUsername.Text = user.Username;
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                user.UpdateUser(NewEmail.Text,NewPass.Text);
                err = "updated details";
            }
        }
    }
}