using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    // Hardcoded API key - a typical issue
    private const string ApiKey = "12345-ABCDE-SECRET-KEY";

    static async Task FetchData()
    {
        string url = $"https://example.com/data?api_key={ApiKey}";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseData);
            }
            else
            {
                throw new Exception("Failed to fetch data");
            }
        }
    }

    static async Task Main(string[] args)
    {
        try
        {
            await FetchData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
