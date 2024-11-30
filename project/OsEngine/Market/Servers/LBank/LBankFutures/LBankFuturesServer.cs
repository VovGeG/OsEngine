using Newtonsoft.Json;
using OsEngine.Entity;
using OsEngine.Logging;
using OsEngine.Market.Servers.Entity;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using WebSocket4Net;
using System.Security.Cryptography;

namespace OsEngine.Market.Servers.LBank.LBankFutures
{
    public class LBankFuturesServer : AServer
    {
        public LBankFuturesServer()
        {

        }
    }

    public class LBankFuturesServerRealization : IServerRealization
    {
        public ServerType ServerType => throw new NotImplementedException();

        public ServerConnectStatus ServerStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ServerTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IServerParameter> ServerParameters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action ConnectEvent;
        public event Action DisconnectEvent;
        public event Action<List<Security>> SecurityEvent;
        public event Action<List<Portfolio>> PortfolioEvent;
        public event Action<MarketDepth> MarketDepthEvent;
        public event Action<Trade> NewTradesEvent;
        public event Action<Order> MyOrderEvent;
        public event Action<MyTrade> MyTradeEvent;
        public event Action<string, LogMessageType> LogMessageEvent;

        public void CancelAllOrders()
        {
            throw new NotImplementedException();
        }

        public void CancelAllOrdersToSecurity(Security security)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void ChangeOrderPrice(Order order, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void GetAllActivOrders()
        {
            throw new NotImplementedException();
        }

        public List<Candle> GetCandleDataToSecurity(Security security, TimeFrameBuilder timeFrameBuilder, DateTime startTime, DateTime endTime, DateTime actualTime)
        {
            throw new NotImplementedException();
        }

        public List<Candle> GetLastCandleHistory(Security security, TimeFrameBuilder timeFrameBuilder, int candleCount)
        {
            throw new NotImplementedException();
        }

        public void GetOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }

        public void GetPortfolios()
        {
            throw new NotImplementedException();
        }

        public void GetSecurities()
        {
            throw new NotImplementedException();
        }

        public List<Trade> GetTickDataToSecurity(Security security, DateTime startTime, DateTime endTime, DateTime actualTime)
        {
            throw new NotImplementedException();
        }

        public void SendOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void Subscrible(Security security)
        {
            throw new NotImplementedException();
        }
    }
}
