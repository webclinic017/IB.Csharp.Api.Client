/* Copyright (C) 2019 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IB.Tws.Client
{
    /**
     * @class PriceIncrement
     * @brief Class describing price increment
     * @sa EClient::reqMarketRule, EWrapper::marketRule
     */
    public class PriceIncrement
    {
        private double lowEdge;
        private double increment;

        /**
         * @brief The low edge
         */
        public double LowEdge
        {
            get { return lowEdge; }
            set { lowEdge = value; }
        }

        /**
         * @brief The increment
         */
        public double Increment
        {
            get { return increment; }
            set { increment = value; }
        }

        public PriceIncrement()
        {
        }

        public PriceIncrement(double lowEdge, double increment)
        {
            LowEdge = lowEdge;
            Increment = increment;
        }
    }
}
