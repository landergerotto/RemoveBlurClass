using RemoveBlur;
using System;
using System.Text.RegularExpressions;
using static System.Console;

await main();

async Task main()
{
    try
    {
        HttpClient client = new HttpClient();

        WriteLine("URL:\n> ");
        string url = ReadLine();

        string page = await client.GetStringAsync(url);
        string name = "Exercicio qualquer";
        string cssClass = "class=\"styles__BlurContentContainer-sc-1iq53xf-0 cVgapz paywall blur-content\"";

        WriteLine(await RespondeAi.RemoveBlur(
            page,
            cssClass,
            name));
    }
    catch (System.Exception)
    {
        WriteLine("Failed to find the webpage, try again!");
    }
}
