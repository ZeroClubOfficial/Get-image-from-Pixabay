using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Nodes;


namespace Get_image_from_Pixabay
{
    public partial class mainHall : Form
    {
        public mainHall()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //https://pixabay.com/api/?key=25829393-af32bf17ec8386b5941fb5f8f&q=yellow+flowers&image_type=photo
            //25829393-af32bf17ec8386b5941fb5f8f


        }

        private async void btGet_Click(object sender, EventArgs e)
        {
            string rawContent;
            string imageUrl;
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, @"https://pixabay.com/api/?key=25829393-af32bf17ec8386b5941fb5f8f&q="+word.Text+@"&image_type=photo");
            using (var responseMessage = await client.SendAsync(request))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    rawContent= await responseMessage.Content.ReadAsStringAsync();
                    JsonNode jsonContent = JsonNode.Parse(rawContent);
                    imageUrl = jsonContent["hits"][0]["webformatURL"].GetValue<string>();
                    picture.ImageLocation = imageUrl;
                }
                   
            }
        }
    }
}
