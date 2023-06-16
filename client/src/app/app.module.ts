import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminModule } from './admin/admin.module';
import { UiModule } from './ui/ui.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';
import { HttpClientModule } from '@angular/common/http';
import { DeleteDirective } from './directives/admin/delete.directive';
import { DeleteDialogComponent } from './dialogs/delete-dialog/delete-dialog.component';
import { FileUploadComponent } from './services/common/file-upload/file-upload.component';
import { FileUploadDialogComponent } from './dialogs/file-upload-dialog/file-upload-dialog.component';
import { FileUploadModule } from './services/common/file-upload/file-upload.module';
import { JwtModule } from '@auth0/angular-jwt';



@NgModule({
  declarations: [
    AppComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AdminModule, UiModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    NgxSpinnerModule,
    HttpClientModule,
    FileUploadModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: () => localStorage.getItem("accessToken"),
        allowedDomains:["localhost:7019"]
      }
    })
  ],
  providers: [
    {provide: "baseUrl", useValue: "https://localhost:7019/api", multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
