namespace SynthMania.Models;

public class PaymentCard
{
    public string CardName { get; set; }
    public double CardNumber { get; set; }
    public string ExpirationDate { get; set; }
    public int CVV { get; set; }

    public CardTypeEnum CardType { get; set; } = CardTypeEnum.Credit;

    public enum CardTypeEnum
    {
        Debit,
        Credit
    }
}