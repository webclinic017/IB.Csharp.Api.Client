/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System;

namespace IB.Tws.Client
{
    /**
     * @class OrderComboLeg
     * @brief Allows to specify a price on an order's leg
     * @sa Order, ComboLeg
     */
    public class OrderComboLeg
    {

        double price;

        /**
         * @brief The order's leg's price
         */
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public OrderComboLeg()
        {
            price = Double.MaxValue;
        }

        public OrderComboLeg(double p_price)
        {
            price = p_price;
        }

        public override bool Equals(Object other)
        {
            if (this == other)
            {
                return true;
            }
            else if (other == null)
            {
                return false;
            }

            OrderComboLeg theOther = (OrderComboLeg)other;

            if (price != theOther.Price)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(price, Price);
        }
    }
}
