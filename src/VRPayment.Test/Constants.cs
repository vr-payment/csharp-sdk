/**
 * VR Payment C# SDK
 *
 * This library allows to interact with the VR Payment payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://www.vr-payment.de
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using VRPayment.Client;
using VRPayment.Model;

namespace VRPayment.Test;

public static class Constants
{
    public const long SPACE_ID = 82470;
    public const long APPLICATION_USER_ID = 140366;
    public const string AUTHENTICATION_KEY = "dvZsZdp+CLyi6RqBJuJER88CrrROHLz3VNuAkZI5U6s=";
    public const long TEST_CARD_PAYMENT_METHOD_CONFIGURATION_ID = 382448;
    public const long TEST_CUSTOMER_ID = 1234;

    /// <summary>
    /// Singleton <see cref="Configuration"/> instance for specific service class.
    /// </summary>
    /// <remarks>
    /// To ensure the Configuration is static (shared and single across the application).
    /// Unlike a global static approach, the Configuration.new() method creates independent instances,
    /// allowing for configuration flexibility and avoiding shared state across the application.
    /// </remarks>
    public static readonly Configuration Config = new(applicationUserId: APPLICATION_USER_ID,
        authenticationKey: AUTHENTICATION_KEY);

    public static readonly AuthenticatedCardRequest MOCK_CARD_DATA =
            new AuthenticatedCardRequest(
                cardData: new AuthenticatedCardDataCreate(
                    primaryAccountNumber: "4111111111111111",
                    expiryDate: "2026-12"
                ),
                paymentMethodConfiguration: TEST_CARD_PAYMENT_METHOD_CONFIGURATION_ID
            );
}