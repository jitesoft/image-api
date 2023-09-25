using StackExchange.Redis;

namespace Lib.Queue.Redis;

public class QueueService : IQueueService
{
    private readonly IConnectionMultiplexer _connectionMultiplexer;

    public QueueService(IConnectionMultiplexer connectionMultiplexer)
    {
        _connectionMultiplexer = connectionMultiplexer;
    }

    /// <summary>
    /// Enqueue a message to the end of the queue.
    /// </summary>
    /// <param name="message">Message to enqueue.</param>
    /// <returns>Completed task.</returns>
    public async Task Enqueue(IMessage message)
    {
        var db = _connectionMultiplexer.GetDatabase();
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
