import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './admin/layout/layout.component';
import { DashboardComponent } from './admin/components/dashboard/dashboard.component';
import { HomeComponent } from './ui/components/home/home.component';
import { AuthGuard } from './guards/common/auth.guard';

const routes: Routes = [
  {
    path: "yonetici", component: LayoutComponent, children: [
      {path : "", component: DashboardComponent , canActivate: [AuthGuard]},
      { path: "musteriler", loadChildren: () => import("./admin/components/customers/customers.module").then(module => module.CustomersModule), canActivate: [AuthGuard] },
      { path: "araclar", loadChildren: () => import("./admin/components/products/products.module").then(module => module.ProductsModule), canActivate: [AuthGuard] },
      { path: "siparisler", loadChildren: () => import("./admin/components/orders/orders.module").then(module => module.OrdersModule), canActivate: [AuthGuard] },
    ], canActivate: [AuthGuard]
  },
  { path: "", component: HomeComponent },
  { path: "sepet", loadChildren: () => import("./ui/components/baskets/baskets.module").then(module => module.BasketsModule) },
  { path: "kayit", loadChildren: () => import("./ui/components/register/register.module").then(module => module.RegisterModule) },
  { path: "giris", loadChildren: () => import("./ui/components/login/login.module").then(module => module.LoginModule) },
  { path: "araclar", loadChildren: () => import("./ui/components/products/products.module").then(module => module.ProductsModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
