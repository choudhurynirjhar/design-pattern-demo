
using VisitorPattern.Demo;

var emailVisitor = new EmailVisitor();
var textVisitor = new TextVisitor();
var websocketVisitor = new WebsocketVisitor();

var notificationSender1 = new InvoiceNotificationSender();
notificationSender1.Accept(emailVisitor);
notificationSender1.Accept(textVisitor);
notificationSender1.Send("Invoice");

var notificationSender2 = new MarketingNotificationSender();
notificationSender2.Accept(emailVisitor);
notificationSender2.Accept(textVisitor);
notificationSender2.Accept(websocketVisitor);
notificationSender2.Send("Marketing");