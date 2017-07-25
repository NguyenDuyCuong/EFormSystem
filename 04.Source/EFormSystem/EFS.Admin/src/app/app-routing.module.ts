import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PageNotFoundComponent }    from './not-found.component';

import { CanDeactivateGuard }       from './guards/can-deactive.guard';
import { AuthGuard }                from './guards/auth.guard';
import { SelectivePreloadingStrategy } from './selective-preloading-strategy';

const appRoutes: Routes = [  
  // {
  //   path: 'dashboard',
  //   loadChildren: 'app/dashboard/dashboard.module#DashboardModule',
  //   canLoad: [AuthGuard]
  // },
  { path: '',   redirectTo: '/dashboard', pathMatch: 'full', },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {
        enableTracing: true, // <-- debugging purposes only
        preloadingStrategy: SelectivePreloadingStrategy,

      }
    )
  ],
  exports: [
    RouterModule
  ],
  providers: [
    CanDeactivateGuard,
    SelectivePreloadingStrategy
  ]
})
export class AppRoutingModule { }
