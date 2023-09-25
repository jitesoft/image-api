namespace Lib.Queue.Rabbit;

public class QueueService : IQueueService
{
    public QueueService() {}

    /// <summary>
    /// Enqueue a message to the end of the queue.
    /// </summary>
    /// <param name="message">Message to enqueue.</param>
    /// <returns>Completed task.</returns>
    public async Task Enqueue(IMessage message)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Dequeue a message from the top of the queue.
    /// </summary>
    /// <returns>Message.</returns>
    public async Task<IMessage> Dequeue()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get number of messages currently queued.
    /// </summary>
    /// <returns>Number of messages in queue.</returns>
    public async Task<int> Count()
    {
        throw new NotImplementedException();
    }
}
