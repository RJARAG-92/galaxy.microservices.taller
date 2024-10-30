import { Component, OnInit } from '@angular/core';
import { ReportPolicyService } from '../../services/data/reports/policy.service';
import { IReportPolicy } from '../../models/ireport-policy'; 

@Component({
  selector: 'app-policy-list',
  templateUrl: './policy-list.component.html',
  styleUrls: ['./policy-list.component.scss']
})
export class PolicyListComponent implements OnInit {
  title!: string;
  policies: IReportPolicy[] = [];

  // Definir las columnas que se mostrarán en la tabla
  displayedColumns: string[] = ['id', 'holder', 'descripcion', 'total', 'agentLogin'];

  constructor(
    private productsService: ReportPolicyService,
  ) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts() {
    this.productsService.getPolicies()
      .subscribe((response: IReportPolicy[]) => {
        this.policies = response;
      });
  }
}
