namespace IB.Api.Client.Enum
{
    public enum OrderStatus
    {
        /// <summary>
        /// Indicates order has not yet been sent to IB server, for instance if there is a delay in receiving the security definition. 
        /// Uncommonly received.
        /// </summary>
        ApiPending,
        /// <summary>
        /// Indicates the order was sent, but confirmation has not been received that it has been received by the destination. 
        /// Most commonly because exchange is closed.
        /// </summary>
        PendingSubmit,
        /// <summary>
        /// Indicates that a request has been sent to cancel an order but confirmation has not been received of its cancellation.
        /// </summary>
        PendingCancel,
        /// <summary>
        /// Indicates that a simulated order type has been accepted by the IB system and that this order has yet to be elected. 
        /// The order is held in the IB system until the election criteria are met. At that time the order is transmitted to the order destination as specified.
        /// </summary>
        PreSubmitted,
        /// <summary>
        /// Indicates that your order has been accepted at the order destination and is working.
        /// </summary>
        Submitted,
        /// <summary>
        /// After an order has been submitted and before it has been acknowledged, an API client can request its cancellation, producing this state.
        /// </summary>
        ApiCancelled,
        /// <summary>
        /// Indicates that the balance of your order has been confirmed cancelled by the IB system. 
        /// This could occur unexpectedly when IB or the destination has rejected your order. For example, if your order is subject to price checks
        /// </summary>
        Cancelled,
        /// <summary>
        /// Indicates that the order has been completely filled.
        /// </summary>
        Filled,
        /// <summary>
        /// Indicates an order is not working, possible reasons include:
        /// - It is invalid or triggered an error. A corresponding error code is expected to the error() function. This error may be a reject, for example a regulatory size reject.
        /// - The order is to short shares but the order is being held while shares are being located.
        /// - An order is placed manually while the exchange is closed.
        /// - An order is blocked by due to a precautionary setting and appears there in an untransmitted state
        /// </summary>
        Inactive
    }
}
