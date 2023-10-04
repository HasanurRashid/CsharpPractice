using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueueDemo
{
    public partial class Operation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Token"] == null)
            {
                Queue<int> tokenQueue = new Queue<int>();
                Session["Token"] = tokenQueue;
            }
           
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServeCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeCustomer(txtCounter3, 3);
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Queue<int> queueToken = (Queue<int>)Session["Token"];
            
            lblStatus.Text = "There are " + queueToken.Count.ToString() + " customers before you in the queue";
            if(Session["LastTokenNumberToServe"] == null)
            {
                Session["LastTokenNumberToServe"] = 0;
            }
            int nextNumber =(int)Session["LastTokenNumberToServe"] + 1;
            Session["LastTokenNumberToServe"] = nextNumber;
            queueToken.Enqueue(nextNumber);
            AddToken(queueToken);

        }

        private void ServeCustomer(TextBox texbox,int counterNumber)
        {
            Queue<int> tokenToServe = (Queue<int>)Session["Token"];
            if(tokenToServe.Count==0)
            {
                texbox.Text = "No Customer";
                txtDisplay.Text = string.Empty;
            }
            else
            {
                int nextCustomer = tokenToServe.Dequeue();
                texbox.Text = nextCustomer.ToString();
                txtDisplay.Text = "Token number " + nextCustomer.ToString() + " please go to counter number " + counterNumber.ToString();
                AddToken(tokenToServe);
            }
        }

        private void AddToken(Queue<int> tokenQueue)
        {
            tokenList.Items.Clear();
            foreach(int token in tokenQueue)
            {
                tokenList.Items.Add(token.ToString());
            }
        }
    }
}