﻿using System.Threading.Tasks;
using Omise.Models;

namespace Omise.Resources {
    public class ChargeResource : BaseResource<Charge>,
    IListable<Charge>,
    IListRetrievable<Charge>,
    ICreatable<Charge, CreateChargeRequest>,
    IUpdatable<Charge, UpdateChargeRequest> {
        public ChargeResource(IRequester requester)
            : base(requester, Endpoint.Api, "/charges") {
        }

        public async Task<Charge> Capture(string chargeId) {
            return await Requester.Request<Charge>(
                Endpoint,
                "POST",
                $"{BasePath}/{chargeId}/capture"
            );
        }

        public async Task<Charge> Reverse(string chargeId) {
            return await Requester.Request<Charge>(
                Endpoint,
                "POST",
                $"{BasePath}/{chargeId}/reverse"
            );
        }
    }
}