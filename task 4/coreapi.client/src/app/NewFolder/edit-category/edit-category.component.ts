import { Component } from '@angular/core';
import { UrlService } from '../../service/url.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit-category',
  standalone: false,
  templateUrl: './edit-category.component.html',
  styleUrl: './edit-category.component.css'
})
export class EditCategoryComponent {
  constructor(private _url: UrlService, private _route: Router, private active: ActivatedRoute) { }

  ngOnInit() {

  }


  editCategory(data: any) {
    let categoryId = this.active.snapshot.paramMap.get("id");

    var DataForm = new FormData();
    DataForm.append("Name", data.Name)
    DataForm.append("Description", data.Description)

    this._url.putCategory(categoryId, data).subscribe(() => {

    })
  }
}
