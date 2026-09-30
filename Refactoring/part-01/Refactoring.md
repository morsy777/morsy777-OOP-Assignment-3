# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
> this class violates ocp because every time we need to add a new shipping method we have to modify it, so I refactored it using factory pattern to make it open for adding new shipping methods without modifying the existing code.

- What did you change?
> I created an interface called IShippingCostCalculatorFactory and implemented it in the AramexShippingCostCalculatorFactory, FedExShippingCostCalculatorFactory, and DHLShippingCostCalculatorFactory. Each factory class is responsible for creating the appropriate shipping cost calculator based on the shipping method. This way, we can easily add new shipping methods by creating new factory classes without modifying the existing code.

> In the Program.cs, I created an object its base type is IShippingCostCalculatorFactory and its actual object is AramexShippingCostCalculatorFactory then I used Create() to create AramexShippingCostCalculator and at end I use Calculate().
---

## OrderProcessor

- What was the problem?
> The OrderProcessor violate DIP because it depends on concrete classes (SqlOrderRepository and SmtpEmailSender), so to refactoring it I made it depend on abstractions (IOrderRepository and IEmailSender) instead of concrete classes. I also used primary constructor to inject the dependencies and in this case The High level (OrderProcessor) and Low level modules (other classes) depend on abstractions.

- What did you change?

---

## Notifications

- What was the problem?
- What did you change?

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no):
