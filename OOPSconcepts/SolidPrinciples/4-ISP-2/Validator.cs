namespace OOPSconcepts.SolidPrinciples._4_ISP_2
{
    public abstract class Validator
    {
        public abstract bool Validate(Invoice invoice);
    }

    // validate invoice
    // validate tax rate
    // validate subtotal
    // validate calculated tax
    // validate invoice total

    public class ValidateInvoice
    {
        private readonly List<Invoice> validators;

        public ValidateInvoice(List<Invoice> validators)
        {
            this.validators = validators;
        }

        public bool Validate(Invoice invoice)
        {
            return validators.All(c => this.Validate(invoice));
        }
    }

    public class ValidateTaxRate : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.TaxRate > 0;
        }
    }

    public class ValidateSubTotal : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.SubTotal > 0;
        }
    }

    public class ValidateTaxCalculation : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.CalculateTax() > 0;
        }
    }

    public class ValidateInvoiceTotal : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.CalulateTotal() > 0;
        }
    }
}
