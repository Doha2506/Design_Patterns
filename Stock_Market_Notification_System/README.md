🧪 Observer Pattern Task

🧠 Scenario:

You are building a Stock Market Notification System.

There are multiple types of subscribers (like EmailSubscriber, SMSSubscriber, etc.) who want to get notified when a stock price changes.

🔧 Requirements:

1. Create a Stock class (the Subject):
It has a Price property.

It keeps a list of observers (subscribers).

It provides methods to:

Attach(IObserver observer)

Detach(IObserver observer)

Notify() all observers when price changes

🔁 When the stock price changes, it should notify all subscribers.

2. Create an IObserver interface:
With a method Update(decimal newPrice);

3. Create two concrete observers:
EmailSubscriber → writes to console: "Email - New stock price: 102.5"

SMSSubscriber → writes to console: "SMS - New stock price: 102.5"

4. Demonstration:

Create a Stock object.

Attach an email and SMS subscriber.

Change the stock price.

See notifications printed from both observers.

💡 Bonus (optional):

Add a third observer: PushNotificationSubscriber

Detach one observer midway and show it's no longer notified