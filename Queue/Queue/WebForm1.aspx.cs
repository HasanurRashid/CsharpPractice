using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Queue
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblMessage.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue.";

            if (Session["LastTokenTokenNumberIssued"] == null)
            {
                Session["LastTokenTokenNumberIssued"] = 0;
            }
            int nextTokenNumber = (int)Session["LastTokenTokenNumberIssued"] + 1;
            Session["LastTokenTokenNumberIssued"] = nextTokenNumber;
            tokenQueue.Enqueue(nextTokenNumber);
            AddItems(tokenQueue);
        }

        private void AddItems(Queue<int> tokenQueue)
        {
            tokenList.Items.Clear();
            foreach (int token in tokenQueue)
            {
                tokenList.Items.Add(token.ToString());
            }
        }

        private void NextCustomerToBeServed(TextBox text, int counterNumber)
        {
            Queue<int> token = (Queue<int>)Session["TokenQueue"];
            if (token.Count == 0)
            {
                text.Text = "No Customer";
            }
            else
            {
                int nextCustomer = token.Dequeue();
                text.Text = nextCustomer.ToString();
                txtDisplay.Text = "Token number " + nextCustomer.ToString() + " please go to counter number "+ counterNumber.ToString();
                AddItems(token);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NextCustomerToBeServed(txtbox1, 1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NextCustomerToBeServed(txtbox2, 2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            NextCustomerToBeServed(txtbox3, 3);
        }

       
    }
}