using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueueExampleDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }

        }
        
        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customers before you in the queue.";

            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }
            int nextTokenNumberToBeIssued = (int)Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
            tokenQueue.Enqueue(nextTokenNumberToBeIssued);

            AddTokensToListBox(tokenQueue);

        }

        private void AddTokensToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServeToNextCustomer(TextBox text, int counterNo)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if(tokenQueue.Count ==0)
            {
                text.Text = "No Customer To Serve";
            }
            else
            {
                int nextCustomerToServe = tokenQueue.Dequeue();
                text.Text = nextCustomerToServe.ToString();
                txtDisplay.Text = "Token number: " + nextCustomerToServe.ToString() + " Please go to counter no " + counterNo.ToString();
                AddTokensToListBox(tokenQueue);
            }
        }
        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServeToNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeToNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeToNextCustomer(txtCounter3, 3);
        }
    }
}