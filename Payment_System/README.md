Task 1: The Strategy Pattern
📌 Scenario:
You're building a payment system that supports multiple payment methods like:

Credit Card

PayPal

Bank Transfer

Users should be able to choose a payment method at runtime, and the system should process it without hardcoding the logic for each method inside the core payment processor.

🎯 Your Objectives:
✅ Apply the Strategy Pattern:

Define a common interface for payment strategies.

Implement multiple payment strategies (CreditCard, PayPal, BankTransfer).

Use composition (not inheritance) to allow switching strategies at runtime.

✅ Follow OCP (Open/Closed Principle) and DIP:

Make sure your code is open for extension (adding new payment methods) but closed for modification.

Depend on abstractions, not concrete classes.

🧠 Hints:
The IPaymentStrategy interface should have a method like ProcessPayment(decimal amount).

CreditCardPayment, PayPalPayment, and BankTransferPayment classes implement this interface.

The PaymentService (or similar) should accept any IPaymentStrategy, not be hardcoded to one.