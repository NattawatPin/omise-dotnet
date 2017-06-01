# CHANGE LOG

# v2.5.1

* **NEW:** `Schedule.charge.description` attribute.
* **NEW:** [Installments](https://www.omise.co/installment-payment).
* **NEW:** Fail-fast transfers.

# v2.5.0

* **CHANGED:** Library now targets .NET Standard 1.2 instead of the PCL.
* **CHANGED:** Library is now built with Visual Studio for Mac 2017
* **CHANGED:** Library now sends data in JSON format instead of form-data.
* **CHANGED:** Resources with parent-child relationship such as Refunds which are
  Charge-specific are now accessed through a new `client.Charge("chrg_id")` method.
* **FIXED:** GetHashCode() on models now handles nulls correctly.
* **NEW:** Schedules API.
* **NEW:** Forex API.
* **NEW:** Metadata API for Charge and Customer.
* **NEW:** Refund, Transfer and Link can now be searched.
* **NEW:** Miscellaneous additions to existing APIs.

# v2.4.2

* Add newly available search scopes.

# v2.4.1

* Fix enum serialization with `[EnumMember(Value=null)]` not working correctly as intended.

# v2.4.0

* Adds support for the new [Internet Banking](https://www.omise.co/internet-banking-is-now-live)
  payment channel

# v2.3.0

* Allows `expiration_month` and `expiration_year` to be null.

# v2.2.0

* Adds support for the new Link API.
* Upgrade test suites to NUnit 3.5

# v2.1.0

* Adds support for the newly released Search API.
* Retarget to .NET 4.0 (previously 4.0.3)
* Upgrade test suites to NUnit 3.4.1

# v2.0.9

* Adds missing `reversed` charge status.

# v2.0.8

* Adds missing `void` parameter for Refund API.

# v2.0.7

* Adds new `client.Charges.Reverse` API method.

# v2.0.6

* Adds new `Charge.reversed` field.

# v2.0.5

* Upgrade Newtonsoft.JSON to 8.0.3
* Adds missing `Client.APIVersion` setting (mistakenly left out).
* Adds missing `ScopedList.Location` field.

# v2.0.4

* Correct dependency list in nuspec.

# v2.0.3

* Fix wrong `Newtonsoft.Json` dependency version.

# v2.0.2

* Fix wrong `order` parameter serialization.

# v2.0.1

* Update new/removed model fields.

# v2.0.0

* Rewrite while maintaining similar API surface.
* Drops pre-4.0 support. (v1.0 is still available for that.)
* Targets Mono/PCL for maximum portability.

### Pre-2.0

See [v1.0 change logs](https://github.com/omise/omise-dotnet/blob/v1.0/CHANGELOG.md) for
more information.
