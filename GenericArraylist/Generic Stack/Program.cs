using System;
using System.Collections.Generic;

class BrowserHistory
{
    private Stack<string> history = new Stack<string>();

    public void VisitPage(string url)
    {
        Console.WriteLine($"Visiting: {url}");
        history.Push(url);
    }

    public void GoBack()
    {
        if (history.Count > 1)
        {
           
            history.Pop();
            Console.WriteLine($"Going back to: {history.Peek()}");
        }
        else
        {
            Console.WriteLine("No previous page in history.");
        }
    }
    public void ShowHistory()
    {
        Console.WriteLine("Browser History:"+history.Count);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BrowserHistory browser = new BrowserHistory();

        browser.VisitPage("https://google.com");
        browser.VisitPage("https://github.com");
        browser.VisitPage("https://stackoverflow.com");

        browser.ShowHistory();
        browser.GoBack();
        browser.GoBack();
        browser.GoBack();
        Console.ReadLine();

    }
}