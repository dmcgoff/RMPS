/* Defines the product entity */
export interface ICourseOld {
  id: number;
  productName: string;
  productCode: string;
  category: string;
  tags?: string[];
  releaseDate: string;
  price: number;
  description: string;
  starRating: number;
  imageUrl: string;
}

export interface ICourse {
  id: string;
  name: string;
  number: string;
  typeId: string;
  typeName: string,
  descriptorId: string;
  descriptorName: string;
  statusId: string;
  statusName: string;
  description: string;
  notes: string;
  creationDate: string;
  updateDate: string;
  changedById: string;
  isActive: boolean;
}