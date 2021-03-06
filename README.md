# ModelConverter
 A C# Library to convert the model class to idictionary and datatable to list model class.

## [Install Package](https://www.nuget.org/packages/AshfaqAliZardariOfficial.Util.ModelConverter/)
> ##### Using Package Manager
> ```
> Install-Package AshfaqAliZardariOfficial.Util.ModelConverter -Version 1.1.1
> ```
> ##### Using .NET CLI
> 
> ```
> dotnet add package AshfaqAliZardariOfficial.Util.ModelConverter --version 1.1.1
> ```
> ##### Using PackageReference
> 
> ```
> <PackageReference Include="AshfaqAliZardariOfficial.Util.ModelConverter" Version="1.1.1" />
> ```
> ##### Using Paket CLI
> ```
> paket add AshfaqAliZardariOfficial.Util.ModelConverter --version 1.1.1
> ```
> ##### Using Script & Interactive
> ```
> #r "nuget: AshfaqAliZardariOfficial.Util.ModelConverter, 1.1.1"
> ```
> ##### Using Cake
> ```
> // Install AshfaqAliZardariOfficial.Util.ModelConverter as a Cake Addin
> #addin nuget:?package=AshfaqAliZardariOfficial.Util.ModelConverter&version=1.1.1
> 
> // Install AshfaqAliZardariOfficial.Util.ModelConverter as a Cake Tool
> #tool nuget:?package=AshfaqAliZardariOfficial.Util.ModelConverter&version=1.1.1
> ```

## How do I use
##### Convert the Model Class to IDictionary<string, object> object.
```csharp
UserModel User = new UserModel(); // Your model class object.
User.name = "Ashfaq Ali Zardari"; // Your model class property.
User.email = "ashfaqalizardariofficial@gmail.com"; // Your model class property.

// Get key values IDictionary<string, object> parameters from your user model class.
IDictionary<string, object> parameters = ModelConverter<RecipientModel>.GetDictionary(User); 
```
Optional
```csharp
// The following model class name property will not be added to IDictionary<string, object> object.
List<string> HiddenProperties = new string[];
HiddenProperties.Add("name");

// Get key values IDictionary<string, object> parameters from your user model class except
// for HiddenProperties string name properties.
IDictionary<string, object> parameters = ModelConverter<RecipientModel>.GetDictionary(User, HiddenProperties); 

```
##### Convert System.Data.DataTable to System.Collections.Generic.List<ModelClass> object.
```csharp
DataTable UsersTable = // Your users table data.
// Get Users list List<UserModel> from your users datatable.
List<UserModel> Users = ModelConverter<UserModel>.GetModelList<UserModel>(UsersTable); 
```

## :clock3: Versions
| Version | Last updated |
| --- | --- |
| [1.1.1](https://www.nuget.org/packages/AshfaqAliZardariOfficial.Util.ModelConverter/1.1.1) | Nov 22, 2021, 4:35 PM GMT+5 |
| [1.1.0](https://www.nuget.org/packages/AshfaqAliZardariOfficial.Util.ModelConverter/1.1.0) | Nov 20, 2021, 8:15 PM GMT+5 |
| [1.0.0](https://www.nuget.org/packages/AshfaqAliZardariOfficial.Util.ModelConverter/1.0.0) | Nov 20, 2021, 12:29 PM GMT+5 |

## :book: Release Notes
**v1.1.1**
- Small bug fixed on GetModelList.
 
**v1.1.0**
- Hide model properties feature added on GetDictionary.

**v1.0.0**
- Convert System.Data.DataTable to System.Collections.Generic.List<ModelClass> object.
- Convert the Model Class to IDictionary<string, object> object.
## Contact and Supporting Info
Feel free to contact me on <a href="mailto:ashfaqalizardariofficial@gmail.com" target="_blank" title="ashfaqalizardariofficial@gmail.com"><img src="https://ssl.gstatic.com/ui/v1/icons/mail/rfr/logo_gmail_lockup_default_1x_r2.png" alt="ashfaqalizardariofficial@gmail.com" width="70" /></a>  
  
  <a href="https://paypal.me/ashfaqalizardari247?country.x=CA&locale.x=en_US" target="_blank" title="paypal.me/ashfaqalizardari247"><img src="https://www.paypalobjects.com/paypal-ui/logos/svg/paypal-color.svg" alt="PayPalMe" width="160" /></a>    <a href="https://www.buymeacoffee.com/ashfaqalizardari" target="_blank" title="buymeacoffee.com/ashfaqalizardari"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" width="160" /></a>

## :balance_scale: License
  Copyright (c) Ashfaq Ali Zardari. All rights reserved.
  
  Licensed under the [MIT](https://github.com/AshfaqAliZardariOfficial/ModelConverter/blob/master/LICENSE) License.
