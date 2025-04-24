using System;

namespace BookAuthorEditor
    {
        public class Counter
        {
            private int threshold;
            private int total;

            // Event declaration
            public event EventHandler ThresholdReached;

            // Constructor to set the threshold
            public Counter(int passedThreshold)
            {
                threshold = passedThreshold;
                total = 0;
            }

            // Add method to increase the count and raise event if threshold is met
            public void Add()
            {
                ++total;

                if (total == threshold)
                {
                    total = 0; // Reset to allow future triggers
                    ThresholdReached?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }


    


