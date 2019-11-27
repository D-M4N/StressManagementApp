using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace SimpleApp
{
    public class GagGenerator
    {
        public async Task<string> GetRandomJoke()
        {
            HttpClient httpClient = new HttpClient();

            string dj = await httpClient.GetStringAsync("https://icanhazdadjoke.com/slack");

            Gag gag = JsonConvert.DeserializeObject<Gag>(dj);

            
            string returnString = string.Empty;

            

            int index = 0;

            while (index < gag.attachments.Count)
            {
                returnString = gag.attachments[index].text;

                index++;
            }

            

            return returnString;


            
        }
    }
}
   
