using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

using System.IO.Pipes;
using System.Text;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var date = _date.Now;
        var answer = $"Day{date: dd 'of' MMMM, yyyy}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number04()
    {
        var date = _date.Now;
        var answer = $"{date:'Year: 'yyyy, 'Month: 'MM, 'Day: 'dd}";
        Console.WriteLine(answer);

        return answer;

    }

    public string Number05()
    {
        var date = _date.Now;
        var answer = $"{date,10:dddd}";


        return answer;
    }

    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date,10:t}{date,10:dddd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var date = _date.Now;
        var answer = $"{date:'h:'h, 'm:'mm, 's:'ss}";
        Console.WriteLine(answer); //

        return answer;
    }

    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy.MM.dd.h.mm.ss}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:f3}"; //f3: outputs 3 decimal numbers  
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var date = _date.Now;
        int answer = Convert.ToInt32($"{date:yyyy}");
        string hexValueYear = answer.ToString("X2");
        Console.WriteLine(hexValueYear);
        return hexValueYear;


        //2.2019.01.22
    }
}
