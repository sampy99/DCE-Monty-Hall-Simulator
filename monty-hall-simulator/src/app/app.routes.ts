import { Routes } from '@angular/router';
import { SimulationComponent } from './simulation/simulation.component';

export const routes: Routes = [
  { path: '', component: SimulationComponent },
  { path: 'simulation', component: SimulationComponent },
];
