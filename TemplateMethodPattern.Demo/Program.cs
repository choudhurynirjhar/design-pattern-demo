/*
using TemplateMethodPattern.Demo.TemplateMethod;

var cart = new EmailCart();
cart.Checkout();

var cart1 = new TextCart();
cart1.Checkout();
*/

using TemplateMethodPattern.Demo.SOLID;

var itemValidator = new ItemValidator();
var paymentExecutor = new PaymentExecutor();

var emailReciptSender = new EmailReceiptSender();
var textReceiptSender = new TextReceiptSender();

var cart = new Cart(itemValidator, paymentExecutor, emailReciptSender);
cart.Checkout();

cart = new Cart(itemValidator, paymentExecutor, textReceiptSender);
cart.Checkout();