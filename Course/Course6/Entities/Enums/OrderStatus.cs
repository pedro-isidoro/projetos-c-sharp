namespace Course6.Entities.Enums
{
    //orderStatus é derivado de um tipo base int
    internal enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
