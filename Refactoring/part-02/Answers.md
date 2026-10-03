# Part 02 — answers

---

## Reports

- What was the problem?
> The same code repeated in the three classes, this violate DRY principle, and also the classes were violating the OCP, because every time we need to add a new report exporter we need to modify the existing code.

- What did you change?
> I movie the frequently changing behavior (Format()) behind an abstractation and I create a base class ReportExporter that contains the shared state and the three classes inherit from it to implement their own Format(), after my refactoring, we can add a new report exporter without modifying the existing code, just by creating a new class that inherits from ReportExporter and implement the Format() method.

- Why did you choose that approach?
> Because there a strong is-a realationship + there is a member (Format()) must be a contract, in this case abstract class is perfered over an interface to avoid DRY violation.

---

## Enrollment

- What was the problem?
- What did you change?
- Why did you choose that approach?
