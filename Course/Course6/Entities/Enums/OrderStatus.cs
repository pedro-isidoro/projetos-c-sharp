namespace Course6.Entites.Enums
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
