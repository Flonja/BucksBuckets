using System;

namespace Bucket.Data
{
    public class WaterBucket
    {
        public WaterBucket() : this(0)
        {
        }

        public WaterBucket(int content) : this(content, 12)
        {
        }

        public WaterBucket(int content, int capacity)
        {
            Content = content;
            Capacity = capacity; // Ik weet dat ik niet aan de opdracht voldoe
        }

        public event EventHandler Full;
        public event EventHandler<int> Overflowing;
        public event EventHandler<int> Overflowed;

        public int Capacity { get; protected set; }
        public int Content { get; protected set; }

        public void Fill(int amount)
        {
            if (Content > Capacity)
            {
                Full?.Invoke(this, EventArgs.Empty);
                return;
            }

            int overflowed = 0;
            for(int i = 0; i <= amount; i++)
            {
                if (Content > Capacity)
                {
                    Overflowing?.Invoke(this, ++overflowed);
                }

                Content += 1;

                if (Content == Capacity)
                {
                    Full?.Invoke(this, EventArgs.Empty);
                }
            }

            if(overflowed > 0)
            {
                Overflowed?.Invoke(this, overflowed);
            }
        }

        public void Fill(WaterBucket bucket)
        {
            Fill(bucket.Content);
        }

        public void Empty()
        {
            Content = 0;
        }

        public void Empty(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Content -= 1;
            }
        }
    }
}
