﻿using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using Net.payOS;
using Net.payOS.Types;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        private readonly BaseRepository<Payment> _basesRepository;
        private readonly DBContext _dbContext;

        public PaymentRepository(DBContext dbContext) : base(dbContext)
        {
            _basesRepository = new BaseRepository<Payment>(dbContext);
            _dbContext = dbContext;
        }

        public async Task<PaymentLinkInformation> cancelPaymentLink(int id, string reason)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var cliend_id = configuration["Environment:PAYOS_CLIENT_ID"];
            var api_key = configuration["Environment:PAYOS_API_KEY"];
            var checkSum_key = configuration["Environment:PAYOS_CHECKSUM_KEY"];

            PayOS payOS = new PayOS(cliend_id, api_key, checkSum_key);

            PaymentLinkInformation paymentLinkInformation = await payOS.cancelPaymentLink(id, reason);
            return paymentLinkInformation;
        }

        public async Task<string> confirmWebhook(string url)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var cliend_id = configuration["Environment:PAYOS_CLIENT_ID"];
            var api_key = configuration["Environment:PAYOS_API_KEY"];
            var checkSum_key = configuration["Environment:PAYOS_CHECKSUM_KEY"];

            PayOS payOS = new PayOS(cliend_id, api_key, checkSum_key);

            return await payOS.confirmWebhook(url);
        }

        public async Task<CreatePaymentResult> createPaymentLink(PaymentData paymentData)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var cliend_id = configuration["Environment:PAYOS_CLIENT_ID"];
            var api_key = configuration["Environment:PAYOS_API_KEY"];
            var checkSum_key = configuration["Environment:PAYOS_CHECKSUM_KEY"];

            PayOS payOS = new PayOS(cliend_id, api_key, checkSum_key);
            PaymentData payment = new PaymentData
                (
                paymentData.orderCode,
                paymentData.amount,
                "Thanh toan don hang",
                paymentData.items,
                paymentData.cancelUrl,
                paymentData.returnUrl
                );
            CreatePaymentResult createPayment = await payOS.createPaymentLink(paymentData);
            return createPayment;
        }

        public async Task<PaymentLinkInformation> getPaymentLinkInformation(int id)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var cliend_id = configuration["Environment:PAYOS_CLIENT_ID"];
            var api_key = configuration["Environment:PAYOS_API_KEY"];
            var checkSum_key = configuration["Environment:PAYOS_CHECKSUM_KEY"];

            PayOS payOS = new PayOS(cliend_id, api_key, checkSum_key);

            PaymentLinkInformation paymentLinkInformation = await payOS.getPaymentLinkInformation(id);
            return paymentLinkInformation;
        }

        public WebhookData verifyPaymentWebhookData(WebhookType webhookType)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var cliend_id = configuration["Environment:PAYOS_CLIENT_ID"];
            var api_key = configuration["Environment:PAYOS_API_KEY"];
            var checkSum_key = configuration["Environment:PAYOS_CHECKSUM_KEY"];

            PayOS payOS = new PayOS(cliend_id, api_key, checkSum_key);

            WebhookData webhookData = payOS.verifyPaymentWebhookData(webhookType);
            return webhookData;
        }
    }
}
