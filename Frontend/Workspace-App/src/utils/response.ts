export interface Response<T> {
  data: T[];
  httpStatus: number;
  error: string;
}
