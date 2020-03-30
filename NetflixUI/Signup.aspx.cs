using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NetflixBL;

namespace NetflixUI
{
    public partial class Signup : System.Web.UI.Page
    {
        public string err = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                List<Subscription> SubsList = Subscription.GetAllSubs();
                for (int i = 0; i < SubsList.Count; i++)
                {
                    string info = SubsList[i].Description + " - Price: " + SubsList[i].Amountpermonth.ToString();
                    subscription.Items.Add(info);
                    subscription.Items[i].Value = SubsList[i].SubscriptionID.ToString();
                    //Do we really need it?
                    subscription.Items[i].Text = info;

                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Subscription SelectedSub = new Subscription(int.Parse(subscription.SelectedValue));
                NetflixWS.NetflixWS proxyObj = new NetflixWS.NetflixWS();
                NetflixWS.Card c = new NetflixWS.Card();
                c.CardNumber = CreditCard.Text;
                c.Owner = int.Parse(Owner.Text);
                c.CVV = int.Parse(CVV.Text);
                c.ExpMonth = int.Parse(ExpMonth.Text);
                c.ExpYear = int.Parse(ExpYear.Text);
                c.FirstName = FirstName.Text;
                c.LastName = LastName.Text;
                NetflixWS.Transaction t = new NetflixWS.Transaction();
                t.CardNumber = CreditCard.Text;
                t.Payee = "Netflix";
                t.Amount = SelectedSub.Amountpermonth;
                if (proxyObj.IsPaid(t.Payee,t.CardNumber))
                {
                    err = " Card allready is in use for another account";
                    return;
                }
                if (!proxyObj.CanPay(c,t))
                {
                    err = "Cant pay for this subscription with this card";
                    return;
                }
                bool worked = NetflixBL.General.SignUp(username.Text, password.Text, 1, subscription.SelectedIndex + 1, email.Text,CreditCard.Text);
                if (!worked)
                {
                    err = "username already exist! please change username";
                    return;
                }
                if (!proxyObj.Pay(c,t))
                {
                    //NOTREACHED!
                    err = "user registed but couldnt pay for some reasone";
                    return;
                }
                err = "you have sucsussfully signed up!";
                Response.Redirect("Login.aspx");
            }
        }
    }
}