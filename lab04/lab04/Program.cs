using lab04;
using lab04.Domain;
using lab04.Domain.Builders;
using lab04.Domain.Formatters;
using lab04.Domain.Senders;

Logger.Instance.Log("Program started.");

Settings.Instance["language"] = "en";
Settings.Instance["windowSize"] = "3024x1964";
Logger.Instance.Log($"Language: {Settings.Instance["language"]}");
Logger.Instance.Log($"Window: {Settings.Instance["windowSize"]}");

var hero = new CharacterBuilder()
    .SetStrength(10)
    .SetAgility(7)
    .SetIntelligence(4)
    .Build();

Logger.Instance.Log($"Built character: {hero}");

var sql = new SqlQueryBuilder()
    .Select("name", "age")
    .From("users")
    .Where("age > 18")
    .OrderBy("name")
    .Build();

Logger.Instance.Log($"Generated SQL: {sql}");

IMessageFormatter plain = new PlainTextFormatter();
IMessageFormatter html = new HtmlFormatter();

var emailSender = new EmailSender();
var smsSender = new SmsSender();

var emailMsg = new Message(emailSender, html);
var smsMsg = new Message(smsSender, plain);

emailMsg.Send("Hello <b>User</b>!");
smsMsg.Send("Hello User!");

IDevice tv = new Television();
IDevice radio = new Radio();

var basicRemote = new RemoteControl(tv);
var advancedRemote = new RemoteControl(radio);

basicRemote.TogglePower();
advancedRemote.TogglePower();

Logger.Instance.ShowLog();
Logger.Instance.Log("Program finished. Press any key to exit.");
Console.ReadKey();