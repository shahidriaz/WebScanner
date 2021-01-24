using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Code written by Shahid Riaz Bhatti on January 25, 2021
/// This code was written to clear the concept of sync vs async programming model.
/// Post is also written against it and its URL is http://argumentexception.com/2021/01/18/asynchronous-in-c/
/// </summary>
namespace Async_Practical
{
    public partial class Form1 : Form
    {
        #region Global Variable
        List<string> listofURLS = new List<string>();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Accept a URL and create a list and append some keywords in URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private List<string> PopulateTargetURL(string url)
        {
            
            listofURLS.Add(url + "/index");
            listofURLS.Add(url + "/images");
            listofURLS.Add(url + "/download");
            listofURLS.Add(url + "/2006");
            listofURLS.Add(url + "/news");
            listofURLS.Add(url + "/crack");
            listofURLS.Add(url + "/serial");
            listofURLS.Add(url + "/wp-login.php");
            return listofURLS;
        }
        #region Sync Call
        /// <summary>
        /// This method iterates through the Listof Urls and hit those urls and display 
        /// response and their status code inside the list view
        /// </summary>
        private void CheckUrls()
        {
            foreach (var item in listofURLS)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    lstScaningResult.Items.Add(new ListViewItem(new string[]
                    {
                    item,
                    Convert.ToString(HitURL(item))
                    }));
                }
            }
        }
        /// <summary>
        /// Method which hit the URL and send back the status code
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private HttpStatusCode HitURL(string path)
        {
            HttpStatusCode myHttpWebResponse = new HttpStatusCode();
            Uri myUri = new Uri(path);
            WebRequest request = WebRequest.Create(myUri);
            try
            {
                myHttpWebResponse = ((HttpWebResponse)request.GetResponse()).StatusCode;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    return HttpStatusCode.NotFound;
                }
            }
            return myHttpWebResponse;
        }
        #endregion
        /// <summary>
        /// Event for sync method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            lstScaningResult.Items.Clear();
            PopulateTargetURL(txtURL.Text);
            CheckUrls();
        }
        /// <summary>
        /// event for async button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            PopulateTargetURL(txtURL.Text);
            CheckUrlsAsync();
        }
        /// <summary>
        /// Iterates through the URLS in async manner and wait for the result and then display the result in list view
        /// </summary>
        private async void CheckUrlsAsync()
        {
            lstScaningResult.Items.Clear();
            foreach (var item in listofURLS)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    HttpStatusCode task = await Task.Run(()=>HitURLAsync(item));
                    lstScaningResult.Items.Add(new ListViewItem(new string[]
                    {
                        item,
                        Convert.ToString(task)
                    }));
                }
            }
        }
        /// <summary>
        /// Hit the URL in asycn manner
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private async Task<HttpStatusCode> HitURLAsync(string path)
        {

            return await Task.Run(() => { 
                HttpStatusCode myHttpWebResponse = new HttpStatusCode();
                Uri myUri = new Uri(path);
                WebRequest request = WebRequest.Create(myUri);
                try
                {
                    myHttpWebResponse = ((HttpWebResponse)request.GetResponse()).StatusCode;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("404"))
                    {
                        return HttpStatusCode.NotFound;
                    }
                }
                return myHttpWebResponse;
            });
            
        }
    }
}
