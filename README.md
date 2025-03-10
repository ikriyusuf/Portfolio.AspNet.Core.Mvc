# Portfolio.AspNet.Core.Mvc

**Portfolio.AspNet.Core.Mvc**, ASP.NET Core MVC kullanılarak geliştirilmiş, katmanlı mimariye sahip bir kişisel portföy web sitesidir. Projede, temiz kod prensipleri ve çeşitli tasarım desenleri (Repository, Service Layer, Dependency Injection, MVC) kullanılarak sürdürülebilir, modüler ve test edilebilir bir yapı oluşturulmuştur.

## İçindekiler

- [Özellikler](#özellikler)
- [Teknolojiler](#teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)

## Özellikler

- **Katmanlı Mimari / MVC**: Uygulama, Model, View ve Controller katmanlarına ayrılarak modüler ve okunabilir hale getirilmiştir.
- **Repository Pattern**: Veri erişim işlemleri, repository katmanı üzerinden yönetilerek kod tekrarının önüne geçilmiştir.
- **Service Layer Pattern**: İş mantığı, controller'dan ayrılmış ve servis katmanında toplanmıştır.
- **AutoMapper**: Veri dönüşümleri için AutoMapper kullanılarak, nesneler arası dönüşüm işlemleri basit ve yönetilebilir hale getirilmiştir.
- **Dependency Injection**: Bileşenler arası gevşek bağımlılık sağlanarak test edilebilirlik ve genişletilebilirlik artırılmıştır.
- **Responsive Tasarım**: Farklı cihazlarda uyumlu, modern bir kullanıcı arayüzü sunar.
- **Kolay Genişletilebilirlik**: Yeni özelliklerin eklenmesi ve mevcut özelliklerin güncellenmesi için esnek bir yapı.

## Teknolojiler

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **AutoMapper**
- **C#**
- **SQL Server** (diğer veritabanları da kullanılabilir: SQLite, PostgreSQL)
- **Bootstrap** (veya tercih ettiğiniz başka bir CSS framework)

## Kurulum

### Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- **MSSQL**: Bu projede Microsoft SQL Server (MSSQL) kullanılmıştır. SQL Server'ı yükleyip, veritabanı bağlantı ayarlarınızı `appsettings.json` dosyasında yapılandırın.

### Adımlar

1. **Repository'yi klonlayın**:
    ```bash
    git clone https://github.com/ikriyusuf/Portfolio.AspNet.Core.Mvc.git
    ```

2. **Proje dizinine geçin**:
    ```bash
    cd Portfolio.AspNet.Core.Mvc
    ```

### Kullanılan Paketler

Projede aşağıdaki NuGet paketleri kullanılmaktadır:

- `Microsoft.AspNetCore.Identity.EntityFrameworkCore` (Version 8.0.13)
- `Microsoft.EntityFrameworkCore.SqlServer` (Version 9.0.2)
- `Microsoft.EntityFrameworkCore.Tools` (Version 9.0.2)
- `Microsoft.VisualStudio.Web.CodeGeneration.Design` (Version 9.0.0)
- `Microsoft.EntityFrameworkCore` (Version 9.0.2)
- `AutoMapper.Extensions.Microsoft.DependencyInjection` (Version 12.0.1)

3. **Veritabanı bağlantı ayarlarını yapılandırın**:
    - `appsettings.json` dosyasında `ConnectionStrings` bölümüne MSSQL veritabanı bağlantı bilgilerinizi girin.

4. **Migration işlemlerini uygulayın**:

    Migration işlemini iki şekilde uygulayabilirsiniz:

    - **.NET CLI ile**:
      1. Yeni bir migration oluşturun:
         ```bash
         dotnet ef migrations add InitialCreate
         ```
      2. Veritabanını güncellemek için:
         ```bash
         dotnet ef database update
         ```

    - **NuGet Package Manager Console ile**:
      1. Yeni migration eklemek için:
         ```bash
         Add-Migration InitialCreate
         ```
      2. Veritabanı güncellemesini yapmak için:
         ```bash
         Update-Database
         ```

5. **Projeyi çalıştırın**:
    ```bash
    dotnet run
    ```

## Kullanım

Bu uygulama, kişisel portföyünüzü dijital ortamda yönetmenizi sağlar. Uygulama çalıştığında aşağıdaki işlemleri gerçekleştirebilirsiniz:

- **Portföy Yönetimi**: Projelerinizi, deneyimlerinizi, eğitim geçmişinizi ve kişisel bilgilerinizi ekleyebilir, güncelleyebilir veya silebilirsiniz.
- **Admin Paneli**: Yönetici paneli üzerinden portföyünüzdeki içerikleri kolayca yönetebilir, yeni projeler ekleyebilir veya mevcut bilgileri güncelleyebilirsiniz. Admin paneli sadece yetkilendirilmiş kullanıcılar tarafından erişilebilir.
- **Veri Yönetimi**: Projenin veri erişim katmanı, Repository Pattern ile yapılandırılmıştır ve tüm işlemler Service Layer üzerinden yönetilmektedir. Bu sayede verilerinizi merkezi bir şekilde kontrol edebilir, güvenli bir şekilde işleyebilirsiniz.

## Proje Yapısı

```plaintext
Portfolio
│
├── Entities/              # Domain modelleri ve veri yapıları
├── Repositories/          # Repository Pattern ile veri erişim katmanı
├── Services/              # İş mantığını yöneten servis katmanı
├── Portfolio/             # Asıl proje
│   ├── Controllers/       # MVC Controller'ları
│   ├── Views/             # Razor view dosyaları
│   ├── appsettings.json   # Konfigürasyon ayarları
│   ├── Areas/             # Area yapısı (Admin gibi)
│   │   └── Admin/         # Admin paneli ve admin ile ilgili sayfalar
│   │       ├── Controllers/ # Admin paneli için controller'lar
│   │       └── Views/      # Admin paneli için Razor view'lar
│   ├── Infrastructure/    # Uygulama altyapı dosyaları
│   │   ├── Extensions/     # Uygulama geneline ait extension metodlar
│   │   └── Mapper/        # AutoMapper profil ve haritalama işlemleri
│   └── Components/        # Uygulama genelinde kullanılan bileşenler
